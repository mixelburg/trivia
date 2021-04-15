import socket

HOST = '127.0.0.1'  # The server's hostname or IP address
PORT = 5050        # The port used by the server

def main():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        print("[+] socket opened")
        s.connect((HOST, PORT))
        print("[+] socket connected")

        string = input("enter string")

        s.sendall(string.encode())

        data = s.recv(1024)

    print('Received: ', repr(data))


if __name__ == '__main__':
    try:
        main()
    except:
        print("[!] An error occurred")