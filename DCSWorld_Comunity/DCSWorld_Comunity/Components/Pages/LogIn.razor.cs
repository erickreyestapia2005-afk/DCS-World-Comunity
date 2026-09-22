using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace DCSWorld_Comunity
{

	public class LoginModel
	{
		private readonly NavigationManager NavigationManager;


		[Required(ErrorMessage = "Ingresa tu usuario.")]
		public string Username { get; set; } = string.Empty;


		[Required(ErrorMessage = "Ingresa tu contraseña.")]
		public string Password { get; set; } = string.Empty;


		public bool RememberMe { get; set; }


		public LoginModel()
		{
			
		}


		public void HandleLogin()
		{
			NavigationManager.NavigateTo("/home");
		}
	}
}