/*
* sones GraphDB - Community Edition - http://www.sones.com
* Copyright (C) 2007-2011 sones GmbH
*
* This file is part of sones GraphDB Community Edition.
*
* sones GraphDB is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB. If not, see <http://www.gnu.org/licenses/>.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphQL.Structure.Helper.Enums;
using sones.GraphQL.Result;
using sones.GraphDB.TypeSystem;

namespace sones.GraphQL.GQL.Structure.Helper.Definition.AlterType
{
    /// <summary>
    /// Set the mandatory flag for an attribute
    /// </summary>
    public sealed class AlterType_SetMandatory : AAlterTypeCommand
    {

        /// <summary>
        /// List of mandatory attributes of the given vertex
        /// </summary>
        public List<String> MandatoryAttributes { get; set; }

        /// <summary>
        /// <seealso cref=" AAlterTypeCommand"/>
        /// </summary>
        public override TypesOfAlterCmd AlterType
        {
            get { return TypesOfAlterCmd.Mandatory; }
        }


        public override IVertexView CreateResult(IBaseType myAlteredVertexType)
        {
            throw new NotImplementedException();
        }
    }
}
