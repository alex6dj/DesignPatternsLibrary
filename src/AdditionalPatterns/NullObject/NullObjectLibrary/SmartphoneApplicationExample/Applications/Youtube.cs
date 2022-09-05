﻿using NullObjectLibrary.SmartphoneApplicationExample.Applications.Common;

namespace NullObjectLibrary.SmartphoneApplicationExample.Applications;

public class Youtube : Application
{
    public Youtube(Guid processId)
        : base(processId)
    {
    }

    public override string Name => "Youtube";
}