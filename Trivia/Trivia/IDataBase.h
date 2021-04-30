#pragma once

class IDataBase {
public:
	virtual ~IDataBase() = default;

	virtual bool open() = 0;
	virtual void close() = 0;
};
