using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaReveal
{
    /// <summary>Represents a tree node</summary>    
    public class Node
    {        
        // Contains the 2D position of the node
        private Vector2 position;
        
        // Parent of the node
        private Node parent;

        // Contains the children of the node (zero or more)
        private List<Node> children;

        //whether is visited by traversal
        private bool visited;        

        /// <summary>Constructs a tree node</summary>
        /// <param name="value">the value of the node</param>
        public Node(Vector2 position)
        {
            if (position == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }
            this.position = position;
            this.children = new List<Node>();
            this.visited = false;
        }

        /// <summary>Ability to foreach node</summary>
        public IEnumerator<Node> GetEnumerator()
        {
            return children.GetEnumerator();
        }
              

        /// <summary>The position of the node</summary>
        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>The parent of the node</summary>
        public Node Parent {
            get { return this.parent; }
            set { this.parent = value; } 
        }

        /// <summary>Whether is visited by traversing</summary>
        public bool Visited
        {
            get { return this.visited; }
            set { this.visited = value; }
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

        /// <summary> Check if it is root</summary>        
        /// <returns>if given node is a root node</returns>
        public bool IsRoot
        {
            get { return this.Parent == null; }
        }


        /// <summary> Get all indirect parents of node</summary> 
        public IEnumerable<Node> Ancestors
        {
            get
            {
                if (IsRoot) return Enumerable.Empty<Node>();
                
                return Parent.ToIEnumarable().Concat(Parent.Ancestors);
            }
        }


        /// <summary> Get length of the path from the root to certain node</summary> 
        public int Depth
        {
            get
            {
                return Ancestors.Count();
            }
        }       


    }
}
