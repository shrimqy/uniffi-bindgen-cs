/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using uniffi.mutable_records;

namespace UniffiCS.BindingTests;

public class TestMutableRecords
{
    [Fact]
    public void PropertiesCanBeSet()
    {
        var point = new Point(1);
        point.X = 5;
        point.Y = 2;
        Assert.Equal(new Point(5, 2), point);
    }

    [Fact]
    public void SetValuesCrossTheFfi()
    {
        var point = new Point(1, 2);
        point.X = 10;
        Assert.Equal(new Point(13, 2), MutableRecordsMethods.MovedRight(point, 3));
    }

    [Fact]
    public void RecordsStayPositional()
    {
        var (x, y) = new Point(3, 4);
        Assert.Equal((3, 4), (x, y));
        Assert.Equal(new Point(3, 4) with { Y = 5 }, new Point(3, 5));
    }
}
