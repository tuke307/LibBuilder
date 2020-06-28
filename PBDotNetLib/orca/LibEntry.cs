﻿using System;

namespace PBDotNetLib.orca
{
    /// <summary>
    /// entry in orca/pb library
    /// </summary>
    public class LibEntry : ILibEntry
    {
        #region private

        private DateTime createTime;
        private string comment;
        private string name;
        private int size;
        private Objecttype type;
        private string library;
        private string source;
        private Orca.Version pbVersion;

        #endregion private

        #region properties

        public DateTime Createtime
        {
            get
            {
                return createTime;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public Objecttype Type
        {
            get
            {
                return type;
            }
        }

        public string Library
        {
            get
            {
                return library;
            }
        }

        public string Source
        {
            get
            {
                if (String.IsNullOrEmpty(this.source))
                {
                    new Orca(this.pbVersion).FillCode(this);
                }

                return source;
            }
            set
            {
                source = value;
            }
        }

        #endregion properties

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name">name of the entry</param>
        /// <param name="type">enum type of the object</param>
        /// <param name="createTime">creation datetime</param>
        /// <param name="size">size of object</param>
        /// <param name="library">path to library</param>
        /// <param name="comment">comment of entry</param>
        public LibEntry(string name, Objecttype type, DateTime createTime, int size, string library, orca.Orca.Version pbVersion, string comment = "")
        {
            this.name = name;
            this.type = type;
            this.createTime = createTime;
            this.size = size;
            this.comment = comment;
            this.library = library;
            this.pbVersion = pbVersion;
        }
    }
}