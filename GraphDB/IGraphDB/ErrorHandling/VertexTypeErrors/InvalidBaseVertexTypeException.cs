﻿using System;
using sones.Library.ErrorHandling;

namespace sones.GraphDB.ErrorHandling
{
    /// <summary>
    /// A base vertex type is not a user defined type 
    /// </summary>
    public sealed class InvalidBaseVertexTypeException : AGraphDBVertexTypeException
    {
        public String BaseVertexTypeName { get; private set; }

        /// <summary>
        /// Creates a new InvalidBaseVertexTypeException exception
        /// </summary>
        /// <param name="myBaseVertexTypeName">The name of the base vertex type</param>
        public InvalidBaseVertexTypeException(String myBaseVertexTypeName)
        {
            BaseVertexTypeName = myBaseVertexTypeName;
        }

        public override string ToString()
        {
            return String.Format("The base vertex type [{0}] must be a user defined type.", BaseVertexTypeName);
        }

        public override ushort ErrorCode
        {
            get { return ErrorCodes.InvalidBaseVertexType; }
        }
    }
}