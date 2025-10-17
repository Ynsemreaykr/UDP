import socket
import struct

# UDP soketi oluştur
s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
s.bind(("0.0.0.0", 5005))

print("✅ UDP Server başlatıldı: ")

while True:
    data, addr = s.recvfrom(1024)
    if len(data) != 9:
        continue

    # 2 adet float + 1 byte işlem kodunu ayrıştır
    a = struct.unpack("f", data[0:4])[0]
    b = struct.unpack("f", data[4:8])[0]
    op = data[8]

    if op == 0:
        result = a + b
    elif op == 1:
        result = a - b  
    elif op == 2:
        result = a * b
    elif op == 3:
        result = a / b if b != 0 else 0
    else:
        result = 0

    print(f"Gelen: {a} {['+','-','*','/'][op]} {b} = {result}")

    # Sonucu geri gönder (float olarak)
    s.sendto(struct.pack("f", result), addr)
