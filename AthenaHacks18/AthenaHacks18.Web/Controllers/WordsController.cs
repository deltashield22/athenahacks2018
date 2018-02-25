using AthenaHacks18.Models.Domain;
using AthenaHacks18.Models.Request;
using AthenaHacks18.Services;
using AthenaHacks18.Models.Responses;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AthenaHacks18.Web.Controllers
{
    [AllowAnonymous]
    public class WordsController : ApiController
    {
        readonly IWordsService wordsService;

        public WordsController(IWordsService wordsService)
        {
            this.wordsService = wordsService;
        }

        [HttpGet, Route("api/words")]
        public HttpResponseMessage GetAll()
        {
            List<Word> words = wordsService.GetAll();

            ItemsResponse<Word> response = new ItemsResponse<Word>();
            response.Items = words;

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpGet, Route("api/words/{word}")]
        public HttpResponseMessage GetByWord(string wordStr)
        {
            Word word = wordsService.GetByWord(wordStr);

            ItemResponse<Word> response = new ItemResponse<Word>();
            response.Item = word;

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }


        [HttpGet, Route("api/words/{grade:int}")]
        public HttpResponseMessage GetByGrade(int grade)
        {
            List<Word> words = wordsService.GetByGrade(grade);

            ItemsResponse<Word> response = new ItemsResponse<Word>();
            response.Items = words;

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }

        [HttpPost, Route("api/words")]
        public HttpResponseMessage Create(WordCreateUpdateRequest req)
        {
            if (req == null)
            {
                ModelState.AddModelError("", "No model was sent.");
            }

            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            wordsService.Create(req);


            return Request.CreateResponse(HttpStatusCode.Created, new SuccessResponse());
        }

        [HttpPut, Route("api/words")]
        public HttpResponseMessage Update(WordCreateUpdateRequest req)
        {
            if (req == null)
            {
                ModelState.AddModelError("", "No model was sent.");
            }

            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            wordsService.Update(req);

            return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse());
        }
    }
}
