﻿using Abp.EntityFrameworkCore;
using CXY.CJS.EntityFrameworkCore;
using CXY.CJS.Model;

namespace CXY.CJS.Repository
{
    public class TestRepository : CJSRepositoryBase<Test, string>, ITestRepository
    {
        private readonly IDbContextProvider<CJSDbContext> _dbContextProvider;
        public TestRepository(IDbContextProvider<CJSDbContext> dbContextProvider) : base(dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public bool Add(Test entity)
        {
            Table.Add(entity);
            //Insert(entity);
            Context.SaveChanges();
            return true;
        }

    }
}