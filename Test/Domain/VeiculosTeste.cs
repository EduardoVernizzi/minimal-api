using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculosTest
{
  [TestMethod]
  public void TestarGetSetPropriedades()
  {
    //Arrange
    var veiculo = new Veiculo();

    //Act
    veiculo.Id = 1;
    veiculo.Nome = "Civic";
    veiculo.Marca = "Honda";
    veiculo.Ano = 2016;

    //Assert
    Assert.AreEqual(1, veiculo.Id);
    Assert.AreEqual("Civic", veiculo.Nome);
    Assert.AreEqual("Honda", veiculo.Marca);
    Assert.AreEqual(2016, veiculo.Ano);

  }
}