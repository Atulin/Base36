using Xunit;

namespace Base36.Test
{
    public class DecodingTest
    {
        [Fact]
        public void Static_Decoding_IsCorrect()
        {
            const ulong output = 292_756_934_830;
            const string input = "3QHNX4MM";
            
            var result = Base36.Decode(input);
            
            Assert.Equal(output, result);
        }
        [Fact]
        public void Extension_Decoding_IsCorrect()
        {
            const ulong output = 751_734_092_182;
            const string input = "9LCB2HSM";
            
            var result = input.FromBase36();
            
            Assert.Equal(output, result);
        }
    }
}