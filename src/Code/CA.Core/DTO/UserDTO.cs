﻿using System;

namespace CA.Core.DTO
{
  public class UserDTO
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Passwordhash { get; set; }
    public string Email { get; set; }
    public int NumberOfAttemps { get; set; }
    public int StatusAccount { get; set; }
    public int RoleId { get; set; }
    public bool IsSystemRow { get; set; }
    public int AccountIdCreationDate { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int? AccountIdUpdateDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeleteDate { get; set; }
    public int? AccountIdDeleteDate { get; set; }
  }
}
