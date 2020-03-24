using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TheCodeCamp.Data;
using TheCodeCamp.Models;

namespace TheCodeCamp.Controllers
{
	[RoutePrefix("api/camps")]
	public class CampsController : ApiController
	{
		private readonly ICampRepository _repositroy;
		private readonly IMapper _mapper;

		public CampsController(ICampRepository repositroy, IMapper mapper)
		{
			_repositroy = repositroy;
			_mapper = mapper;
		}

		[Route()]
		public async Task<IHttpActionResult> Get(bool includeTalks = false)
		{

			try
			{
				var result = await _repositroy.GetAllCampsAsync(includeTalks);



				var mappedResult = _mapper.Map<IEnumerable<CampModel>>(result);
				return Ok(mappedResult);


			}
			catch (Exception ex)
			{
				return InternalServerError(ex);
			}

			//return Ok (new { Name = "Shawn", Occupation = "Teacher", Location = "london" });
		}
		[Route("{moniker}")]
		public async Task<IHttpActionResult> GetbyMoniker(string moniker, bool includeTalks = false)
		{
			try
			{
				var result = await _repositroy.GetCampAsync(moniker, includeTalks);
				if (result == null) return NotFound();

				return Ok(_mapper.Map<CampModel>(result));
			}
			catch (Exception ex)
			{

				return InternalServerError(ex);
			}
		}

		

		//The action method searches the database agints a datetime. This comes from ICampRepository
		[Route("searchByDate/{eventDate:datetime}")]
		[HttpGet]
		public async Task<IHttpActionResult> SearchByEventDate(DateTime eventDate, bool includeTalks = false)
		{
			try
			{
				//call the repository where the 
				var result = await _repositroy.GetAllCampsByEventDate(eventDate, includeTalks);
				if (result == null) return NotFound();

				return Ok(_mapper.Map<CampModel[]>(result));
			}
			catch (Exception ex)
			{

				return InternalServerError(ex);
			}

		}


	}
}
