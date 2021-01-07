using Xunit;

namespace Base36.Test
{
    public class EncodingTest
    {
        [Fact]
        public void Static_Encoding_IsCorrect()
        {
            const ulong input = 292_756_934_830;
            const string output = "3QHNX4MM";
            
            var result = Base36.Encode(input);
            
            Assert.Equal(output, result);
        }

        [Fact]
        public void Extension_Encoding_IsCorrect()
        {
            const ulong input = 751_734_092_182;
            const string output = "9LCB2HSM";

            var result = input.ToBase36();
            
            Assert.Equal(output, result);
        }
    }
}