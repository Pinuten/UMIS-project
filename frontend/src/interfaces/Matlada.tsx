enum Size {
  Normal = "Normal",
  Small = "Small",
}

interface Matlada {
  id: number;
  guid: string;
  size: Size;
  createdAt: Date;
  name: string;
}
