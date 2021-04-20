import socket
import json

HOST = '127.0.0.1'  # The server's hostname or IP address
PORT = 5050        # The port used by the server


def prepare_msg(code: int, msg_data: str):
    return f"{code}{str(len(msg_data)).zfill(4)}{msg_data}"

login_temp = {
    "name": "John",
    "pswd": "Hammond"
}

register_temp = {
    "name": "John",
    "pswd": "Hammond"
}

def main():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        print("[+] socket opened")
        s.connect((HOST, PORT))
        print("[+] socket connected")

        string = input("1: login \n 2: sign up")
        if string == "1":
            s.sendall(string.encode(prepare_msg(1, json.dumps(login_temp))))
        elif string == "2":
            s.sendall(string.encode(prepare_msg(2, json.dumps(login_temp))))
        else:
            print(f"[!] unknown command '{string}'")


        data = s.recv(1024)

    print('Received: ', repr(data))


if __name__ == '__main__':
    try:
        main()
    except:
        print("[!] An error occurred")