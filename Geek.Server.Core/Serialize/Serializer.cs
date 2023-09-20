using MessagePack;

namespace Geek.Server.Core.Serialize
{
    public class Serializer
    {
        public static void Serialize<T>(Stream stream, T value)
        {
            MessagePackSerializer.Serialize(stream, value);
        }
        public static byte[] Serialize<T>(T value)
        {
            return MessagePackSerializer.Serialize(value);
        }
        public static T Deserialize<T>(byte[] data)
        {
            return MessagePackSerializer.Deserialize<T>(data);
        }
    }
}