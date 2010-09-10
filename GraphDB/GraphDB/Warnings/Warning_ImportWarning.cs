/*
* sones GraphDB - Open Source Edition - http://www.sones.com
* Copyright (C) 2007-2010 sones GmbH
*
* This file is part of sones GraphDB Open Source Edition (OSE).
*
* sones GraphDB OSE is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB OSE is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB OSE. If not, see <http://www.gnu.org/licenses/>.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.Lib.ErrorHandling;
using sones.Lib;

namespace sones.GraphDB.Warnings
{
    public class Warning_ImportWarning : GraphDBWarning
    {
        public List<IWarning> Warnings { get; private set; }
        public String Query { get; private set; }
        public Int64 Line { get; private set; }

        public Warning_ImportWarning(String myQuery, Int64 myLine)
        {
            //Warnings.AddRange(myWarnings);
            Query = myQuery;
            Line = myLine;
        }

        public override string ToString()
        {
            return String.Concat("Warning(s) for Line ", Line, " Query [", Query, "] ");
        }

    }
}