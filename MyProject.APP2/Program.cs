// See https://aka.ms/new-console-template for more information
using MyProject.BLL;
using MyProject.MODEL;

Usuario user = new Usuario();
//user.Nome = "Teste de Souza";
//user.Login = "testando";
//user.Senha = "teste@123";
//usuarioRepository.Add(user);
user = usuarioRepository.GetById(2);
Console.WriteLine("Nome:" + user.Nome);