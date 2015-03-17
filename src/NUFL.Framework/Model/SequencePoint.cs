﻿//
// OpenCover - S Wilde
//
// This source code is released under the MIT License; see the accompanying license file.
//

using System.Collections.Generic;
using System.Xml.Serialization;

namespace NUFL.Framework.Model
{
    /// <summary>
    /// a sequence point
    /// </summary>
    public class SequencePoint : InstrumentationPoint
    {        
        [XmlAttribute("sl")]
        public int StartLine { get; set; }
        
        [XmlAttribute("sc")]
        public int StartColumn { get; set; }
        
        [XmlAttribute("el")]
        public int EndLine { get; set; }
        
        [XmlAttribute("ec")]
        public int EndColumn { get; set; }
        
        [XmlAttribute("bec")]
        public int BranchExitsCount { get; set; }
        
        [XmlAttribute("bev")]
        public int BranchExitsVisit { get; set; }
        
        [XmlAttribute("fileid")]
        public uint FileId { get; set; }
        
        [XmlAttribute("url")]
        public string Document { get; set; }
        
        internal List<BranchPoint> BranchPoints { get; set; }
    }
}
