//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace Members.DataSources.TeachersUnion
{

    public partial class TBLReplyPrint : XPLiteObject
    {
        Users fuserin;
        [Association(@"TBLReplyPrintReferencesUsers")]
        public Users userin
        {
            get { return fuserin; }
            set { SetPropertyValue<Users>("userin", ref fuserin, value); }
        }
        public struct CompoundKey1Struct
        {
            [Association(@"TBLReplyPrintReferencesTBLMembers")]
            [Persistent("MemberId")]
            public TBLMembers MemberId;
            [Persistent("printdate")]
            public DateTime printdate;
        }
        [Indexed(Name = @"PK_TBLReplyPrint", Unique = true)]
        [Key, Persistent]
        public CompoundKey1Struct CompoundKey1;
    }

}
