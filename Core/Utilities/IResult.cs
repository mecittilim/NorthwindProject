using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IResult
    {
        bool Success { get; } //ekleme işi/ yapışan işlem başarılı mı?
        string Message { get; }
    }
}
