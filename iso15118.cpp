#include <cbv2g/exi_v2gtp.h>
#include <iso15118/message/schedule_exchange.hpp>
#include <iso15118/message/variant.hpp>
#include <iostream>
#include <vector>
#include <cstdlib>
#include <iso15118/io/stream_view.hpp>

uint8_t* readAllStdin(size_t& length) {
    
    std::vector<uint8_t> buffer;
    char temp;

    // Read all input data from stdin
    while (std::cin.get(temp)) {
        buffer.push_back(static_cast<uint8_t>(temp));
    }

    // Allocate memory for the buffer and copy the data
    length = buffer.size();
    uint8_t* data = new uint8_t[length];
    std::copy(buffer.begin(), buffer.end(), data);

    return data;
}

/*
 *
 * g++ iso15118.cpp -I ./libiso15118/build/_deps/libcbv2g-src/include/ -I libiso15118/include/ libiso15118/build/src/iso15118/libiso15118.a ./libiso15118//build/_deps/libcbv2g-build/lib/cbv2g/libcbv2g_tp.a libiso15118/build/_deps/libcbv2g-build/lib/cbv2g/libcbv2g_iso20.a libiso15118/build/_deps/libcbv2g-build/lib/cbv2g/libcbv2g_exi_codec.a -fprofile-arcs -ftest-coverage -o test
 *
 */

int main()
{

    size_t len;
    uint8_t* data = readAllStdin(len);

    const iso15118::io::StreamInputView stream_view{data, len};
    iso15118::message_20::Variant variant(iso15118::io::v2gtp::PayloadType::Part20Main, stream_view);

}
