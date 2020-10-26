using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Woo.Data;
using Woo.Models;

namespace Woo
{
    public static class Functions
    {
        //private static readonly WooContext _context;


        public static string GetData(HttpContext hhcon, Data.WooContext context, string p_key)
        {

            string ret = hhcon.Session.GetString("userid");

            if(ret == null)
            {
                return null;
            }

            if(p_key == "userid")
            {
                ret = hhcon.Session.GetString("userid"); 
            }

            if (p_key == "sellerid")
            {
                ret = hhcon.Session.GetString("sellerid");
            }

            return ret;
        }

        
        public static int GetWareHouse(HttpContext hhcon, Data.WooContext context, string p_UserId)
        {

            int i = 0;
            
            ApplicationUser user;
            

            string userid = hhcon.Session.GetString("login_user");

            user = context.Users.Find(userid);

            return user.WareHouseId;

            /*var ii3 = _context.Users.Include(x => x.WareHouseObj).Where(i => i.us.ID == p_id).Select(m => new
            {
                id = m.ID,
                itemnum = m.ID,
                name = m.EName,
                price = m.ItemPrices[0].ItemPrice
            }).ToList();

            return w_id;*/
        }

        public static object GetItenInfo(Data.WooContext context, int p_id)
        {
            //List str = "";

            ////var item = context.Item.Find(id);

            //var ii = context.Item.Include(i => i.ItemPrices).ToList();
            //var ii2 = context.Item.Include(i => i.ItemPrices).Where(i => i.ID == item.ID).ToList();

            //var ii4 = context.Item.Include(i => i.ItemPrices).Where(i => i.ID == id).ToList();

            var ii3 = context.Item.Include(i => i.ItemPrices).Where(i => i.ItemId == p_id).Select(m => new
             {
                id = m.ItemId,
                itemnum = m.ItemId,
                name = m.EName,
                price = m.ItemPrices[0].ItemPrice
             }).ToList();

            //var t1 = context.Item.Where(i => i.ID == item.ID).i


            return ii3;
        }


        //public async static Task<List<List<string>>> RunReport(Data.WooContext context, ReportH rep)
        public async static Task<List<object[]>> RunReport(Data.WooContext p_context, string p_query)
        {
            //List<string> data;

            //data = { "a1","b1"};

            List<List<string>> groups = new List<List<string>>();

            List<object[]> groups1 = new List<object[]>();

            var conn = p_context.Database.GetDbConnection();
            try
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    //string query = "SELECT EnrollmentDate, COUNT(*) AS StudentCount "
                    //    + "FROM Person "
                    //    + "WHERE Discriminator = 'Student' "
                    //    + "GROUP BY EnrollmentDate";
                    command.CommandText = p_query;
                    DbDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {

                            //int i = 0;
                            //int iq = 0;

                            object[] obj = new object[20];

                            reader.GetValues(obj);

                            //var row = new List<string> { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                            groups1.Add(obj);
                        }
                    }
                    reader.Dispose();
                }
            }
            catch(Exception e)
            {
                string s = e.Message;
            }
            finally
            {
                conn.Close();
            }

            return groups1;
        }
            

    }
}
