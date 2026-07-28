using System;
using static System.Console; 

string splitLine = new('-', 100);
WriteLine(splitLine);
WriteLine($"{"Type",-10} {"Byte(s) of memory",20} {"Min",30} {"Max",35}");
WriteLine(splitLine);
WriteLine($"{"sbyte",-10} {sizeof(sbyte),20} {sbyte.MinValue,30} {sbyte.MaxValue,35}");
WriteLine($"{"byte",-10} {sizeof(byte),20} {byte.MinValue,30} {byte.MaxValue,35}");
WriteLine($"{"short",-10} {sizeof(short),20} {short.MinValue,30} {short.MaxValue,35}");
WriteLine($"{"ushort",-10} {sizeof(ushort),20} {ushort.MinValue,30} {ushort.MaxValue,35}");
WriteLine($"{"int",-10} {sizeof(int),20} {int.MinValue,30} {int.MaxValue,35}");
WriteLine($"{"uint",-10} {sizeof(uint),20} {uint.MinValue,30} {uint.MaxValue,35}");
WriteLine($"{"long",-10} {sizeof(long),20} {long.MinValue,30} {long.MaxValue,35}");
WriteLine($"{"ulong",-10} {sizeof(ulong),20} {ulong.MinValue,30} {ulong.MaxValue,35}");
WriteLine($"{"float",-10} {sizeof(float),20} {float.MinValue,30} {float.MaxValue,35}");
WriteLine($"{"double",-10} {sizeof(double),20} {double.MinValue,30} {double.MaxValue,35}");
WriteLine($"{"decimal",-10} {sizeof(decimal),20} {decimal.MinValue,30} {decimal.MaxValue,35}");

WriteLine(splitLine);