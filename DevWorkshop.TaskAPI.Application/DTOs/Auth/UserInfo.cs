using System;

public class UserInfo
{
    /// <summary>
    /// Identificador único del usuario
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Nombre completo del usuario
    /// </summary>
    public string FullName { get; set; } = string.Empty;

    /// <summary>
    /// Dirección de correo electrónico
    /// </summary>
    public string Email { get; set; } = string.Empty;

}
