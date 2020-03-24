using EFHelper.Filtering;
using MirrorDB;
using MirrorLayer.Fake.DAL;
using System;
using System.Collections.Generic;

namespace MirrorLayerTester
{
    class Program
    {
        private static readonly DALFakeTable dalFake = DALFakeTable.GetInstance;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestSave();
        }
        public static bool TestSave()
        {
            FakeTable fake = new FakeTable();
            fake.UserName = "saya1";
            fake.UserName2 = "saya2";
            fake.UserName3 = "saya3";
            fake.insert_date = DateTime.Now;
            bool result = dalFake.SaveAsync(fake).GetAwaiter().GetResult();

            fake = new FakeTable();
            fake.UserName = "saya1a";
            fake.UserName2 = "saya2a";
            fake.UserName3 = "saya3a";
            fake.insert_date = DateTime.Now;
            result = dalFake.SaveAsync(fake).GetAwaiter().GetResult();

            fake = new FakeTable();
            fake.UserName = "saya1b";
            fake.UserName2 = "saya2b";
            fake.UserName3 = "saya3b";
            fake.insert_date = DateTime.Now;
            result = dalFake.SaveAsync(fake).GetAwaiter().GetResult();


            fake = new FakeTable();
            fake.UserName = "saya1c";
            fake.UserName2 = "saya2c";
            fake.UserName3 = "saya3c";
            fake.insert_date = DateTime.Now;
            result = dalFake.SaveAsync(fake).GetAwaiter().GetResult();
            return result;

        }
        public static bool TestUpdate()
        {
            FakeTable fake = new FakeTable();
            fake.Id = 1;
            fake.UserName = "saya1update";
            fake.update_date = DateTime.Now;
            bool result = dalFake.UpdateAsync(fake).GetAwaiter().GetResult();

            fake = new FakeTable();
            fake.Id = 2;
            fake.UserName2 = "saya2update";
            fake.update_date = DateTime.Now;
            result = dalFake.UpdateAsync(fake).GetAwaiter().GetResult();
            return result;

        }
        public static bool TestDelete()
        {
            FakeTable fake = new FakeTable();
            fake.Id = 1;
        
            bool result = dalFake.DeleteFisikAsync(fake).GetAwaiter().GetResult();

            fake = new FakeTable();
            fake.Id = 2;
            fake.UserName2 = "saya2update";
            fake.update_date = DateTime.Now;
            result = dalFake.UpdateAsync(fake).GetAwaiter().GetResult();
            return result;

        }
        public static List<FakeTable> TestList0SecondsAsync()
        {
            FakeTable fake = new FakeTable();
            fake.Id = 1;

            List<SearchField> lsf = new List<SearchField>();
            lsf.Add(new SearchField { Name = "username", Operator = "=", Value = "saya" });
            var result = dalFake.List30SecondsAsync(false, lsf).GetAwaiter().GetResult();
            return result;

        }
        public static List<FakeTable> TestListAsync()
        {
            FakeTable fake = new FakeTable();
            fake.Id = 1;
            List<SearchField> lsf = new List<SearchField>();
            lsf.Add(new SearchField { Name = "username", Operator = "=", Value = "saya" });
            var result = dalFake.ListDataAsync(lsf).GetAwaiter().GetResult();
            List<FakeTable> listResult = new List<FakeTable>();
            if (result != null)
                listResult = (List<FakeTable>)result;
            return listResult;

        }
    }
}
