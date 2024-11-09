using Calculadora.Services;

namespace CalculadoraTests;

public class UnitTest1
{
    CalculadoraImp calc = new CalculadoraImp();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int x, int y, int resultado)
    {
        int resultadoCalculadora = calc.Somar(x, y);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(10, 5, 5)]
    public void TesteSubtrair(int x, int y, int resultado)
    {
        int resultadoCalculadora = calc.Subtrair(x, y);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 2, 5)]
    public void TesteDividir(int x, int y, int resultado)
    {
        int resultadoCalculadora = calc.Dividir(x, y);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(5, 5, 25)]
    public void TesteMultiplicar(int x, int y, int resultado)
    {
        int resultadoCalculadora = calc.Multiplicar(x, y);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        calc.Somar(1, 2);
        calc.Somar(3, 4);
        calc.Somar(5, 6);
        calc.Somar(7, 8);

        var lista = calc.HistoricoDeOperacoes();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }
}