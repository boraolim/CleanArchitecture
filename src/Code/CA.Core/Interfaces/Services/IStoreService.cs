﻿using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using CA.Core.DTO;

namespace CA.Core.Interfaces.Services
{
  public interface IStoreService
  {
    Task<StoreDTO> FindStoreAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<StoreDTO>> GetStores(CancellationToken cancellationToken = default);
    Task<CreateStoreDTO> InsertStoreAsync(CreateStoreDTO objDTO, CancellationToken cancellationToken = default);
    Task<UpdateStoreDTO> UpdateStoreAsync(UpdateStoreDTO objDTO, CancellationToken cancellationToken = default);
    Task<DeleteStoreDTO> DeleteStoreAsync(DeleteStoreDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
  }
}
