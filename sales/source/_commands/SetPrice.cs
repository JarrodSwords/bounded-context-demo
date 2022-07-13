﻿using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record SetPrice(
    decimal Price,
    string Sku
) : Command;
