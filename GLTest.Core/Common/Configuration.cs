﻿namespace GLTest.Core.Common
{
    public class Configuration
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string AppDbContext { get; set; }
    }
}
