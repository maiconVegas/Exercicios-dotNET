using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.hyper_optimized_telemetry
{
    public static class TelemetryBuffer
    {
        // EXERCICIO QUE VEIO DO NADA DESSA DIFICULDADE DIFICL MDS KKKKKKKKKKKKKKKKKKKKKKK
        // Explicação para mim mesmo:
        /*
         Assinado não tem o u no inicio: int, short, long
        Nao assinado tem u no inicio: uint, ushort etc...

        Tipos não assinados: Prefixo é igual ao número de bytes.

        ushort (2 bytes) → Prefixo: 2.
        uint (4 bytes) → Prefixo: 4.
        Tipos assinados: Prefixo é calculado como 256 - número de bytes.

        short (2 bytes) → Prefixo: 256 - 2 = 254.
        int (4 bytes) → Prefixo: 256 - 4 = 252.
         */
        public static byte[] ToBuffer(long reading)
        {
            //ulong ui = (ulong)reading;
            //return BitConverter.GetBytes(ui);
            var bytes = reading switch
            {
                //  método Prepend serve para adicionar um elemento no início de uma sequência (IEnumerable).
                < int.MinValue => BitConverter.GetBytes(reading).Prepend((byte)(256 - 8)), //pq é long = 64 bits
                < short.MinValue => BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4)), //pq é int = 32 bits
                < ushort.MinValue => BitConverter.GetBytes((short)reading).Prepend((byte)(256 - 2)), // pq é short = 16 bits
                <= ushort.MaxValue => BitConverter.GetBytes((ushort)reading).Prepend((byte)2), // pq é Ushort = 16 bits
                <= int.MaxValue => BitConverter.GetBytes((int)reading).Prepend((byte)(256 - 4)), // pq é int = 32bits
                <= uint.MaxValue => BitConverter.GetBytes((uint)reading).Prepend((byte)4), // pq é Uint = 32 bits
                _ => BitConverter.GetBytes(reading).Prepend((byte)(256 - 8)) // pq como não atende os requisitos acima, então é long(64bits) de 4... <-> 9... positivos do topo da tabela do exercism

            };
            /*
            Se o array bytes contém 4 bytes:

            byte[] bytes = { 0x2, 0x5, 0xFF, 0x3A };
            bytes.Count():
            Conta os elementos no array: 4.
            9 - bytes.Count():
            Calcula quantos bytes faltam para completar 9: 5.
            new byte[5]:
            Cria um array de 5 bytes: { 0x0, 0x0, 0x0, 0x0, 0x0 }.
            bytes.Concat(...):
            Concatena os dois arrays:
            
            { 0x2, 0x5, 0xFF, 0x3A, 0x0, 0x0, 0x0, 0x0, 0x0 }
            .ToArray():
            Converte para um array de bytes com exatamente 9 elementos.
            */
            return bytes.Concat(new byte[9 - bytes.Count()]).ToArray();
        }

        public static long FromBuffer(byte[] buffer) => buffer[0] switch
        {
            256 - 8 => BitConverter.ToInt64(buffer, 1), // long (64 bits)
            256 - 4 => BitConverter.ToInt32(buffer, 1), // int (32 bits)
            4 => BitConverter.ToUInt32(buffer, 1),    // uint (32 bits)
            256 - 2 => BitConverter.ToInt16(buffer, 1), // short (16 bits)
            2 => BitConverter.ToUInt16(buffer, 1),    // ushort (16 bits)
            _ => 0,
        };

    }
}
