﻿namespace sones.GraphDB.Request
{
    /// <summary>
    /// A request for creating a new vertex type
    /// </summary>
    public sealed class RequestCreateVertexType : IRequest
    {
        #region data

        /// <summary>
        /// The definition of the vertex that is going to be created
        /// </summary>
        public readonly VertexTypeDefinition VertexTypeDefinition;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new request that clears the Graphdb
        /// </summary>
        /// <param name="myVertexTypeDefinition">Describes the vertex that is going to be created</param>
        public RequestCreateVertexType(VertexTypeDefinition myVertexTypeDefinition)
        {
            VertexTypeDefinition = myVertexTypeDefinition;
        }

        #endregion

        #region IRequest Members

        public GraphDBAccessMode AccessMode
        {
            get { return GraphDBAccessMode.TypeChange; }
        }

        #endregion
    }
}