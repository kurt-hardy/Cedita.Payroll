﻿// Copyright (c) Cedita Ltd. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the solution root for license information.

namespace Cedita.Payroll.Abstractions
{
    public interface IPayrollCalculator
    {
        PayrollCalculationResult Calculate(PayrollCalculationRequest payrollData);
    }
}
