/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

// Generated with `mutable_records = true` in `uniffi.toml`.

#[derive(uniffi::Record)]
pub struct Point {
    /// Horizontal position.
    pub x: i32,
    #[uniffi(default = 0)]
    pub y: i32,
}

#[uniffi::export]
pub fn moved_right(point: Point, by: i32) -> Point {
    Point {
        x: point.x + by,
        y: point.y,
    }
}

uniffi::setup_scaffolding!();
