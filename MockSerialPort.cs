using System.IO.Ports;

namespace XCTU_COPY
{
    public class MockSerialPort : SerialPort
    {
        private int readCounter = 0;
        private readonly string[] mockData = {
            "Mock Response 1",
            "Mock Response 2",
            "Mock CAN Message",
            "Mock Data Packet"
        };

        public override string ReadLine()
        {
            // Cycle through predefined mock responses
            string data = mockData[readCounter % mockData.Length];
            readCounter++;
            return data;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            // Log or handle mock writes if needed for debugging
            string hex = BitConverter.ToString(buffer, offset, count);
            Console.WriteLine($"Mock Write: {hex}");
        }
    }
}
