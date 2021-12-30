﻿using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using CA.Core.DTO;

namespace CA.Core.Interfaces.Services
{
  public interface IBrandService
  {
    Task<BrandDTO> FindBrandAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<BrandDTO>> GetBrands(CancellationToken cancellationToken = default);
    Task<CreateBrandDTO> InsertBrandAsync(CreateBrandDTO objDTO, CancellationToken cancellationToken = default);
    Task<UpdateBrandDTO> UpdateBrandAsync(UpdateBrandDTO objDTO, CancellationToken cancellationToken = default);
    Task<DeleteBrandDTO> DeleteBrandAsync(DeleteBrandDTO objDTO, bool autoSave = true, CancellationToken cancellationToken = default);
  }
}
