using System;

namespace QuiqNews.Data.Enums {
    [Flags]
    public enum Permission {
        Read,
        Edit,
        Delete
    }
}