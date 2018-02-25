using AthenaHacks18.Models.Domain;
using AthenaHacks18.Models.Request;
using AthenaHacks18.Models.Responses;
using AthenaHacks18.Services;
using AthenaHacks18.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AthenaHacks18.Web.Controllers
{
    [RoutePrefix("api/students")]
    public class StudentsController : ApiController
    {
        //readonly IStudentsService studentsService;

        //public StudentsController(IStudentsService studentsService)
        //{
        //    this.studentsService = studentsService;
        //}

        ////Insert
        //[HttpPost, Route("")]
        //public HttpResponseMessage Insert(StudentCreateRequest req)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    int newId = studentsService.Insert(req);
        //    ItemResponse<int> response = new ItemResponse<int>();
        //    response.Item = newId;
        //    return Request.CreateResponse(HttpStatusCode.Created, response); 
        //}
        
        //// GET All
        //[HttpGet, Route("")]
        //public HttpResponseMessage GetAll()
        //{
        //    List<Student> students = studentsService.GetAll();
        //    ItemsResponse<Student> response = new ItemsResponse<Student>();
        //    response.Items = students;
        //    return Request.CreateResponse(HttpStatusCode.OK, response);
        //}

        //// GET By Id
        //[HttpGet, Route("{id}")]
        //public HttpResponseMessage GetById(int id)
        //{
        //    Student student = studentsService.GetById(id);
        //    ItemResponse<Student> response = new ItemResponse<Student>();
        //    response.Item = student;
        //    return Request.CreateResponse(HttpStatusCode.OK, response);
        //}


        //// PUT 
        //[HttpPut, Route("{id}")]
        //public HttpResponseMessage Update(int id, StudentUpdateRequest req)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //    }

        //    studentsService.Update(id, req);
            
        //    return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse());
        //}

        //// DELETE
        //[HttpDelete, Route("{id}")]
        //public HttpResponseMessage Delete(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.Conflict, ModelState);
        //    }
        //    try
        //    {
        //        studentsService.Delete(id);
        //    }
        //    catch (IdNotFoundException ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
        //    }

           
        //    return Request.CreateResponse(HttpStatusCode.OK, new SuccessResponse());
        //}
    }
}