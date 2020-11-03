using TDDMicroExercises.TirePressureMonitoringSystem;
using Xunit;

namespace TDDMicroExercises.Test.TirePressureMonitoringSystem.Tests
{
    public class AlarmTest
    {
        [Fact]
        public void Foo()
        {
            Alarm alarm = new Alarm();
            Assert.False(alarm.AlarmOn);
        }
    }
}