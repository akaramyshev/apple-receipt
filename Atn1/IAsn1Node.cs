﻿using System.IO;

namespace AppleReceiptParser.Atn1
{
    /// <summary>
    /// IAsn1Node interface.
    /// </summary>
    public interface IAsn1Node
    {
        /// <summary>
        /// Save node data into Stream.
        /// </summary>
        /// <param name="xdata">Stream.</param>
        /// <returns>true:Succeed; false:failed.</returns>
        bool SaveData(Stream xdata);

        /// <summary>
        /// Get parent node.
        /// </summary>
        Asn1Node ParentNode { get; }

        /// <summary>
        /// Add child node at the end of children list.
        /// </summary>
        /// <param name="xdata">Asn1Node</param>
        void AddChild(Asn1Node xdata);
        
        /// <summary>
        /// Get child node count.
        /// </summary>
        long ChildNodeCount { get; }

        /// <summary>
        /// Retrieve child node by index.
        /// </summary>
        /// <param name="index">0 based index.</param>
        /// <returns>0 based index.</returns>
        Asn1Node GetChildNode(int index);
        
        /// <summary>
        /// Get/Set tag value.
        /// </summary>
        byte Tag { get; set; }
        
        /// <summary>
        /// Get/Set node data by byte[], the data length field content and all the 
        /// node in the parent chain will be adjusted.
        /// </summary>
        byte[] Data { get; set; }

        /// <summary>
        /// Get the deepness of the node.
        /// </summary>
        long Deepness { get; }
        
        /// <summary>
        /// Clear data and children list.
        /// </summary>
        void ClearAll();
    }
}