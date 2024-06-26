﻿namespace CleanArchitecture.Domain.Common;

public abstract class BaseAuditableEntityIdentity : BaseEntityIdentity
{
    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}
