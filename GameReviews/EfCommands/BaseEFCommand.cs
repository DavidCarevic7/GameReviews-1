
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public abstract class BaseEFCommand
    {
        protected GamesContext _context;

        protected BaseEFCommand(GamesContext context)
        {
            _context = context;
        }

        
    }
}
