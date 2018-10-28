using Afazeres.DataContext;
using System;

namespace Afazeres.Repository.Base
{
    public abstract class Repository : IDisposable
    {
        public AfazeresContext ctx;

        public Repository()
        {
            ctx = new AfazeresContext();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}