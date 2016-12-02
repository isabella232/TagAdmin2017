// Guids.cs
// MUST match guids.h

using System;

namespace TagAdmin2017
{
    static class GuidList
    {
        public const string guidTagAdmin2017PkgString = "a1e38ebe-f115-4ad6-bb1a-bf1c62ff4758";
        public const string guidTagAdmin2017CmdSetString = "6e2c826d-b2a3-4900-ac1a-7a8fc03c5df4";
        public const string guidToolWindowPersistanceString = "274285f1-ae76-4c93-8ff4-04a3429077dc";

        public static readonly Guid guidTagAdmin2017CmdSet = new Guid(guidTagAdmin2017CmdSetString);
    };
}