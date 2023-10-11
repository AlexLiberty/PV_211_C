using DZ_12_2;

MyMath bb = new MyMath();
bb.Par(3);
bb.Par(4);

MyDelegate md = new MyDelegate(bb.Min);
md += bb.Sum;
md += bb.Mul;
md.Invoke(5, 4);

