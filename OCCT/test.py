import cadquery


def Make_box():
    return cadquery.Workplane("XY").box(1, 1, 1).toSvg()
