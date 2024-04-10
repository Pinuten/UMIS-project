// Corresponds to the C# enum Size
enum Size {
  Normal = "Normal",
  Small = "Small",
}

// Interface for Matlada that mirrors the C# class
interface Matlada {
  id: number;
  guid: string;
  size: Size;
  createdAt: Date;
  name: string;
}
