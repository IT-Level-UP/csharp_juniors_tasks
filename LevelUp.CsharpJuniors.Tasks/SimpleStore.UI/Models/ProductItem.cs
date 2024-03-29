﻿namespace SimpleStore.UI.Models;

public sealed record ProductItem(Guid Id, string Name, Guid CategoryId, string? Description);