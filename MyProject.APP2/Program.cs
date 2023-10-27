// See https://aka.ms/new-console-template for more information
using MyProject.BLL;
using MyProject.MODEL;



Usuario user = new Usuario();
user = usuarioRepository.GetById(1);
Console.WriteLine("Nome:" + user.Nome);