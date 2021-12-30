﻿namespace CA.Core.Interfaces.Management
{
  public interface IEntityBase<TKey> : IAddEntity<TKey>, IUpdateEntity<TKey>, IDeleteEntity<TKey> { }
}
