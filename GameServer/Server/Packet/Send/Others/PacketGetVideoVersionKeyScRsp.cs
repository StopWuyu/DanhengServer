﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Server.Packet.Send.Others
{
    public class PacketGetVideoVersionKeyScRsp : BasePacket
    {
        public PacketGetVideoVersionKeyScRsp() : base(CmdIds.GetVideoVersionKeyScRsp)
        {
            // FIND A BETTER WAY
            SetData(Convert.FromBase64String("QggwkhhgrOXSCUIIMIgYYKzl0glCCDD+F2Cs5dIJQggw9Bdg7+bSCUIIMOAXYKzl0glCCDDMF2DuzqEHQggwyBVgisSnBkIIML4VYIrEpwZCCDC0FWCKxKcGQggwqhVgisSnBkIIMJYVYO7OoQdCCDCNFWDuzqEHQggwjBVgus+hB0IIMPgUYO7OoQdCCDDuFGDuzqEHQggw5BRg7s6hB0IIMIoUYP2+6gVCCDCAFGD9vuoFQggw9hNg47/qBUIIMLoTYP/SgitCCDCwE2D/0oIrQggw/AJg4dTeB0IIMOgCYOHU3gdCCDDUAmDh1N4HQggwtgJgv/36IUIIMOITYKe3rQVCBzAIYPf4vSFCCDDiGGCs5dIJQggwzglgqvvjBkIIMNAUYKr74wZCBzAVYP/4vSFCBzBmYMm/6gVCBzAFYP/U1R1CCDDpAmDh1N4HQggwnBhg7+bSCUIIMIgJYLf9+iFCCDCwGGCs5dIJQggwnAlgqvvjBkIHMBBg9/i9IUIIMJwTYP/SgitCCDDGFGCXxKcGQggwrgJgkNTeB0IIMLwUYIrEpwZCBzABYPfL2xxCCDDKAmDh1N4HQggw3gJg4dTeB0IIMMcJYKr74wZCCDDyAmDh1N4HQggwrQJgkNTeB0IIMMgJYKr74wZCCDDmGWD25tIJQggwoBVg7s6hB0IHMARg/9TVHUIHMGVgyb/qBUIHMAdg/9TVHUIIMOUZYPbm0glCCDDCF2DuzqEHQgcwA2D/1NUdQgcwZGDJv+oFQggwkhNg99KCK0IIMMACYKe3rQVCBzACYPfL2xxCCDCGA2Dh1N4HQggwkANg4dTeB0IIMJoDYOHU3gdCCDDWF2DuzqEHQggwmwNg4dTeB0IIMM4YYKzl0glCCDC6CWCq++MGQggw6hdgrOXSCUIIMJgKYPLEpwZCCDCkA2Dh1N4HQggwphhgrOXSCUIIMJIJYKr74wZCCDC6GGCs5dIJQggwpglgqvvjBkIIMMQYYO/m0glCCDCwCWCq++MGQggw2BhgrOXSCUIIMMQJYKr74wZCCDDFCWCq++MGQggwghVg7s6hB0IIMP4RYPLEpwZCCDCUFGDjv+oFQggwxglgqvvjBkIIMOwYYPHm0glCCDDYCWCq++MGQggw9BJg/9KCK0IIMIgTYP/Sgis="));
        }
    }
}
