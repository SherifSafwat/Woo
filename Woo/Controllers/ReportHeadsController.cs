using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Woo.Data;
using Woo.Models;
using System.Data;

namespace Woo.Controllers
{
    public class ReportHeadsController : Controller
    {
        private readonly WooContext _context;

        public ReportHeadsController(WooContext context)
        {
            _context = context;
            _context.ReportHead.Include(h => h.ReportTails);



            try
            {
                var modt =  _context.ReportHead.Include(h => h.ReportTails).Single(i => i.ReportHeadId == 1);

                var mod = _context.ReportHead.Find(1);


                var mod1 = _context.ReportHead.Include("ReportTails").FirstOrDefault();

                //int y = 0;
            }
            catch (Exception e)
            {
                string s = e.Message;
            }




        }

        // GET: ReportHeads
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportHead.ToListAsync());
        }

        public async Task<IActionResult> UserIndex()
        {
            return View(await _context.ReportHead.ToListAsync());
        }


        public IActionResult ReportParam(int id)
        {
            ReportHead mod = _context.ReportHead.Find(id);

            //for(int i=0; i<10;i++)
            //{
            //    ViewBag.input1 = mod.Header0; 
            //}

            //ViewBag.input1 = "";

            //var reportH = _context.ReportH.FirstOrDefault(m => m.ID == id);



            return View(mod);
            //return RedirectToAction("RunReport", "Reports",id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReportLayout([Bind("ReportHeadId,ReportEName,ReportAName,ReportSQL,ReportEDesc,ReportADesc,Header0,Header1,Header2,Header3,Header4,Header5,Header6,Header7,Header8,Header9,FromDate,ToDate,Param0,Param1,Param2,Param3,Param4,Param5,Param6,Param7,Param8,Param9,Param10,Param11,Param12,Param13,Param14,Param15,Param16,Param17,Param18,Param19,HeaderParam0,HeaderParam1,HeaderParam2,HeaderParam3,HeaderParam4,HeaderParam5,HeaderParam6,HeaderParam7,HeaderParam8,HeaderParam9,HeaderParam10,HeaderParam11,HeaderParam12,HeaderParam13,HeaderParam14,HeaderParam15,HeaderParam16,HeaderParam17,HeaderParam18,HeaderParam19,Info1,Info2,Info3,Info4,Info5,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] ReportHead reportHead)
        {

            if (ModelState.IsValid)
            {
                //var ii4 = context.Item.Include(i => i.ItemPrices).Where(i => i.ID == id).ToList();
                //ReportH mod = _context.ReportH.Find(reportH.ID);

                try
                {
                    var modt = await _context.ReportHead.Include("ReportTails").SingleAsync(i => i.ReportHeadId == 1);

                    var mod = _context.ReportHead.Find(reportHead.ReportHeadId);
                    

                    var mod1 = _context.ReportHead.Include(h => h.ReportTails).FirstOrDefault(); 

                    //int y = 0;
                }
                catch (Exception e)
                {
                    string s = e.Message;
                }



                try
                {
                    var mod1 = await _context.ReportHead.Include(h => h.ReportTails).ToListAsync();
                }
                catch (Exception e)
                {
                    string s = e.Message;
                }

                try
                {
                    var mod11 = await _context.ReportHead.Where(x => x.ReportHeadId == reportHead.ReportHeadId).ToListAsync();
                }

                catch (Exception e)
                {
                    string s = e.Message;
                }


                try
                {
                    var mod11 =  _context.ReportHead.Include(x => x.ReportTails).Where(x => x.ReportHeadId == reportHead.ReportHeadId).FirstOrDefault();
                }

                catch (Exception e ) {
                    string s = e.Message;
                }

                try
                {
                    ReportHead mod = await _context.ReportHead.SingleAsync(i => i.ReportHeadId == reportHead.ReportHeadId);
                }

                catch (Exception e)
                {
                    string s = e.Message;
                }

                try
                {
                    ReportHead mod = await _context.ReportHead.Include("ReportTails").SingleAsync(i => i.ReportHeadId == reportHead.ReportHeadId);
                }

                catch (Exception e)
                {
                    string s = e.Message;
                }


                //List<object[]> data = await Functions.RunReport(_context, mod);
                //mod.reportT.data = await Functions.RunReport(_context, mod);

                //mod.reportTs[0].labels[0] = mod.reportTs[0].Header0;
                //mod.reportTs[0].labels[1] = mod.reportTs[0].Header1;
                //mod.reportTs[0].labels[2] = mod.reportTs[0].Header2;
                //mod.reportTs[0].labels[3] = mod.reportTs[0].Header3;
                //mod.reportTs[0].labels[4] = mod.reportTs[0].Header4;
                //mod.reportTs[0].labels[5] = mod.reportTs[0].Header5;
                //mod.reportTs[0].labels[6] = mod.reportTs[0].Header6;
                //mod.reportTs[0].labels[7] = mod.reportTs[0].Header7;
                //mod.reportTs[0].labels[8] = mod.reportTs[0].Header8;
                //mod.reportTs[0].labels[9] = mod.reportTs[0].Header9;
                //mod.reportTs[0].labels[10] = mod.reportTs[0].Header10;
                //mod.reportTs[0].labels[11] = mod.reportTs[0].Header11;
                //mod.reportTs[0].labels[12] = mod.reportTs[0].Header12;
                //mod.reportTs[0].labels[13] = mod.reportTs[0].Header13;
                //mod.reportTs[0].labels[14] = mod.reportTs[0].Header14;
                //mod.reportTs[0].labels[15] = mod.reportTs[0].Header15;
                //mod.reportTs[0].labels[16] = mod.reportTs[0].Header16;
                //mod.reportTs[0].labels[17] = mod.reportTs[0].Header17;
                //mod.reportTs[0].labels[18] = mod.reportTs[0].Header18;
                //mod.reportTs[0].labels[19] = mod.reportTs[0].Header19;



                return View();
                //return RedirectToAction(nameof(Index));
            }
            //ReportH mod = _context.ReportH.Find(id);

            //ViewBag.Header0 = Request.Form["Header0"];

            return View();
            //return RedirectToAction("RunReport", "Reports",id);
        }


        // GET: ReportHeads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportHead = await _context.ReportHead
                .FirstOrDefaultAsync(m => m.ReportHeadId == id);
            if (reportHead == null)
            {
                return NotFound();
            }

            return View(reportHead);
        }

        // GET: ReportHeads/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportHeads/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportHeadId,ReportEName,ReportAName,ReportSQL,ReportEDesc,ReportADesc,Header0,Header1,Header2,Header3,Header4,Header5,Header6,Header7,Header8,Header9,FromDate,ToDate,Param0,Param1,Param2,Param3,Param4,Param5,Param6,Param7,Param8,Param9,Param10,Param11,Param12,Param13,Param14,Param15,Param16,Param17,Param18,Param19,HeaderParam0,HeaderParam1,HeaderParam2,HeaderParam3,HeaderParam4,HeaderParam5,HeaderParam6,HeaderParam7,HeaderParam8,HeaderParam9,HeaderParam10,HeaderParam11,HeaderParam12,HeaderParam13,HeaderParam14,HeaderParam15,HeaderParam16,HeaderParam17,HeaderParam18,HeaderParam19,Info1,Info2,Info3,Info4,Info5,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] ReportHead reportHead)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportHead);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportHead);
        }

        // GET: ReportHeads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportHead = await _context.ReportHead.FindAsync(id);
            if (reportHead == null)
            {
                return NotFound();
            }
            return View(reportHead);
        }

        // POST: ReportHeads/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportHeadId,ReportEName,ReportAName,ReportSQL,ReportEDesc,ReportADesc,Header0,Header1,Header2,Header3,Header4,Header5,Header6,Header7,Header8,Header9,FromDate,ToDate,Param0,Param1,Param2,Param3,Param4,Param5,Param6,Param7,Param8,Param9,Param10,Param11,Param12,Param13,Param14,Param15,Param16,Param17,Param18,Param19,HeaderParam0,HeaderParam1,HeaderParam2,HeaderParam3,HeaderParam4,HeaderParam5,HeaderParam6,HeaderParam7,HeaderParam8,HeaderParam9,HeaderParam10,HeaderParam11,HeaderParam12,HeaderParam13,HeaderParam14,HeaderParam15,HeaderParam16,HeaderParam17,HeaderParam18,HeaderParam19,Info1,Info2,Info3,Info4,Info5,Enabled,GrantBy,GrantFromDate,GrantToDate,GrantComment,CreationDate,CreatedID,UpdatingDate,UpdatedID,SysComment")] ReportHead reportHead)
        {
            if (id != reportHead.ReportHeadId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportHead);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportHeadExists(reportHead.ReportHeadId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reportHead);
        }

        // GET: ReportHeads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportHead = await _context.ReportHead
                .FirstOrDefaultAsync(m => m.ReportHeadId == id);
            if (reportHead == null)
            {
                return NotFound();
            }

            return View(reportHead);
        }

        // POST: ReportHeads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportHead = await _context.ReportHead.FindAsync(id);
            _context.ReportHead.Remove(reportHead);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportHeadExists(int id)
        {
            return _context.ReportHead.Any(e => e.ReportHeadId == id);
        }
    }
}
