using System;
using Xunit;

namespace EF.Console.Tests
{
    public class ProcessoUnitTest
    {
        [Fact]
        public void getProcesso_RunningProcess_ReturnOk()
        {
            // Arrange - Preapara��o
            var processo = new Processo();
            var valorEsperado = "Processo rodando...";

            // Act - Execu��o
            var result = processo.getProcesso();

            // Assert - Resultado
            Assert.Equal(result, valorEsperado);
        }
    }
}
