using System;
using System.Collections.Generic;

namespace AreaReveal
{
    /// <summary>Represents a tree node</summary>    
    public class Node
    {        
        // Contains the 2D position of the node
        private Position position;        

        // Contains the children of the node (zero or more)
        private List<Node> children;

        //whether is visited by traversal
        private bool isVisited;

        /// <summary>Constructs a tree node</summary>
        /// <param name="value">the value of the node</param>
        public Node(Position position)
        {
            if (position == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.position = position;
            this.children = new List<Node>();
            this.isVisited = false;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return children.GetEnumerator();
        }

        IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>The position of the node</summary>
        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>The number of node's children</summary>
        public int ChildrenCount
        {
            get { return this.children.Count; }
        }

        /// <summary>Adds child to the node</summary>
        /// <param name="child">the child to be added</param>
        public void AddChild(Node child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            
            this.children.Add(child);
        }

        /// <summary> Gets the child of the node at given index</summary>
        /// <param name="index">the index of the desired child</param>
        /// <returns>the child on the given position</returns>
        public Node GetChild(int index)
        {
            return this.children[index];
        }
    }
}
