using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Galaxie_MVC_Angular;
using Galaxie_MVC_Angular.Dapper;
using Galaxie_MVC_Angular.Models;


namespace Galaxie_MVC_Angular.Controllers
{
    public class Query2Controller : ApiController
    {
        private GalaxieDev2Entities db = new GalaxieDev2Entities();
        private IItemRepository _repository = new ItemRepository();

        // GET api/Query2
        public PagedList GettblItem(string searchtext, int page = 1, int pageSize = 10, string sortBy = "CustomerID", string sortDirection = "asc")
        {
            var pagedRecord = new PagedList();

            pagedRecord.Content = _repository.GetItemByPage(searchtext, page, pageSize, sortBy, sortDirection).ToList();

            // Count
            pagedRecord.TotalRecords = _repository.GetAllItems(searchtext).Count();

            pagedRecord.CurrentPage = page;
            pagedRecord.PageSize = pageSize;

            return pagedRecord;    


            //return _repository.GetAll();   
        }

        // GET api/Query2/5
        [ResponseType(typeof(tblItem))]
        public async Task<IHttpActionResult> GettblItem(int id)
        {
            tblItem tblitem = await db.tblItem.FindAsync(id);
            if (tblitem == null)
            {
                return NotFound();
            }

            return Ok(tblitem);
        }

        // PUT api/Query2/5
        public async Task<IHttpActionResult> PuttblItem(int id, tblItem tblitem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblitem.ItemID)
            {
                return BadRequest();
            }

            db.Entry(tblitem).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/Query2
        [ResponseType(typeof(tblItem))]
        public async Task<IHttpActionResult> PosttblItem(tblItem tblitem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblItem.Add(tblitem);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tblitem.ItemID }, tblitem);
        }

        // DELETE api/Query2/5
        [ResponseType(typeof(tblItem))]
        public async Task<IHttpActionResult> DeletetblItem(int id)
        {
            tblItem tblitem = await db.tblItem.FindAsync(id);
            if (tblitem == null)
            {
                return NotFound();
            }

            db.tblItem.Remove(tblitem);
            await db.SaveChangesAsync();

            return Ok(tblitem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblItemExists(int id)
        {
            return db.tblItem.Count(e => e.ItemID == id) > 0;
        }
    }
}