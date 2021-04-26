import socket
import json

HOST = '127.0.0.1'  # The server's hostname or IP address
PORT = 5050        # The port used by the server
SIZE_LEN = 4
BUFFER_SIZE = 1024
LOGIN = "1"
SIGNUP = "2"

def prepare_msg(code: int, msg_data: str):
    return f"{code}{str(len(msg_data)).zfill(SIZE_LEN)}{msg_data}"

login_temp = {
    "username": "John",
    "password": "Hammond"
}

register_temp = {
    "username": "John",
    "password": "Hammond",
    "mail": "john123@gmail.com"
}

def main():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        print("[+] socket opened")
        s.connect((HOST, PORT))
        print("[+] socket connected")
        s.sendall("hello".encode())
        data = s.recv(BUFFER_SIZE)
        print('Received: ', repr(data))
        string = input("1: login \n 2: sign up")
        if string == LOGIN:
            s.sendall(prepare_msg(int(LOGIN), json.dumps(login_temp)).encode())
        elif string == SIGNUP:
            s.sendall(prepare_msg(int(SIGNUP), json.dumps(register_temp)).encode())
        else:
            print(f"[!] unknown command '{string}'")


        data = s.recv(BUFFER_SIZE)
        print('Received: ', repr(data))


if __name__ == '__main__':
    try:
        main()
    except:
        print("[!] An error occurred")
