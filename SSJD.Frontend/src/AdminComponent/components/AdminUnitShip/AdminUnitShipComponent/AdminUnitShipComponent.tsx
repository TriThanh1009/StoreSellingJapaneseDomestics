import React, { useEffect, useState } from "react"
import { UnitShipModel } from "../../../../Model/UnitShip/UnitShipModel"
import { getUnitShip } from "../../../../Responsitory/UnitShipResponsitory"



const AdminUnitShipComponent:React.FC = () =>{
    const [unitships,setUnitShips] = useState<UnitShipModel[]>()

    useEffect(()=>{
        const fetch = async () =>{
            const data = await getUnitShip()
            setUnitShips(data)
        }
        fetch()
    },[])
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3 d-flex flex-row justify-content-between">
                            <h6 className="m-0 font-weight-bold text-primary">Unit Shipping Table</h6>
                            <button className="button-options">Create</button> 
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="">
                                            <th>ID</th>
                                            <th>Name</th>
                                            <th>Options</th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(unitships) && unitships.map((unitship) => (
                                        <tr>
                                        <td>{unitship.id}</td>
                                        <td>{unitship.name}</td>
                                        <td className="td-options d-flex flex-row gap-2">
                                        <i className="bi bi-pen"></i>
                                        <i className="bi bi-x-octagon"></i>
                                        </td>
                                        </tr>
                                    ))}
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

    )
}


export default AdminUnitShipComponent